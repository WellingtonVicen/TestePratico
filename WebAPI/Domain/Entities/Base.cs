﻿using System.Collections.Generic;

namespace Domain.Entities
{
   public abstract class Base
   {
        public long Id { get; set; }
        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors;

        public abstract bool Validar();
   }
}
