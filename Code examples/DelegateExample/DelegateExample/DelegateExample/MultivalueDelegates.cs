using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    public delegate void Message(string txt);

    class MultivalueDelegates
    {
        private string sender;
        private Message message;

        public MultivalueDelegates(string sender)
        {
            this.sender = sender;
            message = null;
        }

        public MultivalueDelegates(string sender, Message aMessage)
        {
            this.sender = sender;
            message = aMessage;
        }

        public void InstallMessage(Message mes)
        {
            this.message += mes;
        }

        public void UnInstallMessage(Message mes)
        {
            this.message -= mes;
        }

        public void DoSend()
        {
            message("Message from " + sender);
        }

        public static void MultivalueDelegatesMain()
        {
            A a1 = new A(1),
              a2 = new A(2),
              a3 = new A(3);

            MultivalueDelegates m = new MultivalueDelegates("C# @ SDU", a2.MethodA);
            m.InstallMessage(a1.MethodA);
            m.DoSend();
            Console.WriteLine();

            m.InstallMessage(a3.MethodA);
            m.InstallMessage(a3.MethodA);
            m.DoSend();
            Console.WriteLine();

            m.UnInstallMessage(a3.MethodA);
            m.UnInstallMessage(a1.MethodA);
            m.DoSend();
        }
    }

    public class A
    {

        private int state;

        public A(int i)
        {
            state = i;
        }

        public void MethodA(string s)
        {
            Console.WriteLine("A: {0}, {1}", state, s);
        }
    }
}
