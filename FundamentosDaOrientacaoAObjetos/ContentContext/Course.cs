using FundamentosDaOrientacaoAObjetos.ContentContext.Enums;
using System.Collections;
using System.Collections.Generic;

namespace FundamentosDaOrientacaoAObjetos.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }

    }

}