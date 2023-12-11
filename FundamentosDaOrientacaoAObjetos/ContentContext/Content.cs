using System;

namespace FundamentosDaOrientacaoAObjetos.ContentContext
{
    public abstract class Content
    {
        public Content() => Id = Guid.NewGuid();

        public Guid Id { get; set; }

        public int Title { get; set; }

        public int Url { get; set; }

    }

}