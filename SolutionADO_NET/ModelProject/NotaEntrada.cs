using ModelProject;
using System;

namespace ADO_NETProject01
{
    public class NotaEntrada
    {
        public long? Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        

        public NotaEntrada()
        {
            this.Id = null;
        }

        protected bool Equals(NotaEntrada other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((NotaEntrada)obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}