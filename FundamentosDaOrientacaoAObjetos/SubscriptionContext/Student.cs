using FundamentosDaOrientacaoAObjetos.NotificationContext;
using FundamentosDaOrientacaoAObjetos.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosDaOrientacaoAObjetos.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (!IsPremium) return;
            AddNotification(new Notification("Premium", "O aluno já é premium"));
        }

    }
}
