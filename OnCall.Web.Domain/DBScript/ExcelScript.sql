=TEXT(J1,"yyyy-MM-dd HH:mm:ss")

=CONCATENATE("insert into ��λ��Ϣ�����(��ʶ,����,��վID,�ϱ�ʶ,�ֱ�ʶ,�豸,�ȼ�,����)values('",A1,"','",B1,"','",C1,"','",D1,"','",E1,"','",F1,"','",G1,"','",H1,"')")
=CONCATENATE("insert into ���ϴ����(��ʶ,���ϴ���,����,��վID,����״̬,�澯�ȼ�,�豸��ʶ,��ʱʱ��,�װ��ʶ)values('",A1,"','",B1,"','",C1,"','",D1,"','",E1,"','",F1,"','",G1,"','",H1,"','",I1,"')")
=CONCATENATE("insert into �����¼����տ�(ID_KEY,��վID,��ʶ,����,״̬,�豸��ʶ,�ȼ�,�������,�����ʶ,��ʼʱ��,����ʱ��,������ʶ,����ָ��,��ע)values('",A1,"','",B1,"','",C1,"','",D1,"','",E1,"','",F1,"','",G1,"','",H1,"','",I1,"','",TEXT(J1,"yyyy-MM-dd HH:mm:ss"),"','",TEXT(K1,"yyyy-MM-dd HH:mm:ss"),"','",L1,"','",M1,"','",N1,"')")
=CONCATENATE("insert into �����¼���ʷ��(ID_KEY,��վID,��ʶ,����,״̬,�豸��ʶ,�ȼ�,�������,�����ʶ,��ʼʱ��,����ʱ��,������ʶ,����ָ��,��ע)values('",A1,"','",B1,"','",C1,"','",D1,"','",E1,"','",F1,"','",G1,"','",H1,"','",I1,"','",TEXT(J1,"yyyy-MM-dd HH:mm:ss"),"','",TEXT(K1,"yyyy-MM-dd HH:mm:ss"),"','",L1,"','",M1,"','",N1,"')")


=CONCATENATE("insert into ������Ϣ�����(���,��ʶ,����,����,��վID,���ϸ澯,�澯�ȼ�,�������,�����ʶ,�豸��ʶ,״̬���,��ʱʱ��,����ֵ,����ֵ,��������,�װ��ʶ)values('",A1,"','",B1,"','",C1,"','",D1,"','",E1,"','",F1,"','",G1,"','",H1,"','",I1,"',",J1,",'",K1,"',",L1,",",M1,",",N1,",'",O1,"',",P1,")")

=CONCATENATE("insert into ң�ű�λ�¼���ʷ��(ID_KEY,��վID,YXID,ֵ��,״̬,ʱ��,����,comflag,��ע,�ȼ�)values('",A1,"','",B1,"','",C1,"','",D1,"','",E1,"','",TEXT(F1,"yyyy-MM-dd HH:mm:ss"),"','",G1,"','",H1,"','",I1,"','",J1,"')")
