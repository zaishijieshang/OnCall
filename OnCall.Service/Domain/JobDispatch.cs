using OnCall.Service.Domain.Job;
using OnCall.Service.Domain.Job.Entity;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnCall.Service.Domain.Ext;
namespace OnCall.Service.Domain
{
    public class JobDispatch
    {
        public static Action<EJobData> UIExeJobData = null;
        public static Action<EAlarmData> UIExeAlarmData = null;

        public static Action<bool> UIJobStatus = null;
        public static Action<int> UIFaultAlarmCount = null;
        public static Action<int> UISMSCount = null;
        public static Action<int> UIVBitCount = null;
        
        public static JobKey AlarmCrewJob
        {
            get
            {
                JobKey alarmCrewJob = JobKey.Create("AlarmCrewJob", "OnCall");
                return alarmCrewJob;
            }
        }

        public static JobKey SMSSendJob
        {
            get
            {
                JobKey smsSendJob = JobKey.Create("SMSSendJob", "OnCall");
                return smsSendJob;
            }
        }

        public static JobKey AlarmVariableBitJob
        {
            get
            {
                JobKey alarmVariableBitJob = JobKey.Create("AlarmVariableBitJob", "OnCall");
                return alarmVariableBitJob;
            }
        }
        

        private static JobDispatch _JobDispatch;
        public static JobDispatch Instance
        {
            get
            {
                if (_JobDispatch == null)
                {
                    _JobDispatch = new JobDispatch();
                }
                return _JobDispatch;
            }
        }

        private static ISchedulerFactory SchedulerFactory = new StdSchedulerFactory();
        public static IScheduler _Scheduler = SchedulerFactory.GetScheduler();

        public static void CreateJobExecuteInterval<T>(JobKey jobKey, int seconds) where T : IJob
        {
            IJobDetail job = JobBuilder.Create<T>().WithIdentity(jobKey).Build();

            ITrigger trigger = TriggerBuilder.Create()
                .StartNow()
                .WithIdentity(jobKey.Name, jobKey.Group)
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(seconds).RepeatForever())
                .Build();

            _Scheduler.ScheduleJob(job, trigger);
        }

        public static void CreateJobByType(Type jobType, JobKey jobKey, int seconds)
        {
            IJobDetail job = JobBuilder.Create(jobType).WithIdentity(jobKey).Build();

            ITrigger trigger = TriggerBuilder.Create()
                .StartNow()
                .WithIdentity(jobKey.Name, jobKey.Group)
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(seconds).RepeatForever())
                .Build();

            _Scheduler.ScheduleJob(job, trigger);
        }

        public static void Start(JobKey jobKey, int seconds)
        {
            string exMsg = string.Empty;
            try
            {
                if (!_Scheduler.CheckExists(jobKey))//不存在
                {
                    CreateJobByType(BuilderJob.CreateJob(jobKey.Name).GetType(), jobKey, seconds);
                }
                else
                {
                    _Scheduler.ResumeJob(jobKey);//存在则恢复
                }

                UIJobStatus?.Invoke(_Scheduler.IsStarted);
            }
            catch (Exception ex)
            {
                exMsg = ex.Message;
            }

            UIExeJobData?.Invoke(new Job.Entity.EJobData()
            {
                JobTitle = "{0} 服务启动".Format(jobKey.Name),
                ExeResult = _Scheduler.IsStarted ? "成功" : string.Format("失败{0}", "：" + exMsg),
                ExeTime = DateTime.Now,
                Status = _Scheduler.IsStarted ? 0 : 1
            });
        }

        public static void Stop(JobKey jobKey)
        {
            string exMsg = string.Empty;
            try
            {
                if (_Scheduler.CheckExists(jobKey))
                {
                    _Scheduler.Shutdown();
                    //_Scheduler.PauseJob(jobKey);
                    _Scheduler.DeleteJob(jobKey);
                }

                UIJobStatus?.Invoke(_Scheduler.IsStarted);
            }
            catch (Exception ex)
            {
                exMsg = ex.Message;
            }

            UIExeJobData?.Invoke(new Job.Entity.EJobData()
            {
                JobTitle = "{0} 服务停止".Format(jobKey.Name),
                ExeResult = _Scheduler.IsShutdown ? "成功" : "失败{0}".Format(string.IsNullOrEmpty(exMsg) ? "" : "：" + exMsg),
                ExeTime = DateTime.Now,
                Status = _Scheduler.IsShutdown == false ? 0 : 1
            });
        }

        public static void UIDispalyTask(string JobTitle, string ExeResult, int Status = 0)
        {
            UIExeJobData?.Invoke(new Job.Entity.EJobData()
            {
                JobTitle = JobTitle,
                ExeResult = ExeResult,
                ExeTime = DateTime.Now,
                Status = Status
            });
        }
    }
}
