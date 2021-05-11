using System;
using System.Collections.Generic;

namespace amanpowerback.Shared.Entities
{
    public partial class Rutina
    {
        public Guid Id { get; set; }
        public string Ejercicio { get; set; }
        public string Repeticiones { get; set; }
    }
}
