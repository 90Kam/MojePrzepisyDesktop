using System;


namespace MojePrzepisy.Models
{
    public class Przepis
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Tytul { get; set; } = string.Empty;
        public string Kategoria { get; set; } = string.Empty;
        public string Skladniki { get; set; } = string.Empty; // jeden składnik na linię
        public string Instrukcje { get; set; } = string.Empty;
        public bool Ulubiony { get; set; }


        public override string ToString() => Tytul; // ułatwia wyświetlanie w ListBox
    }
}