
namespace HomeWork2
{
    public class Musical_instruments
    {
        public static string? name { get; set; }
        public static string? description { get; set; }

        public Musical_instruments(string? name, string? description)
        {
            //Console.WriteLine($"Instrument name: {name}; Description: {description}");
        }

        public class Violin : Musical_instruments
        {
            public string sound { get; set; }
            public string show { get; set; }
            public string desc { get; set; }
            public string history { get; set; }

            public Violin(string sound, string show, string desc, string history)
                : base(name, description)
            {
                this.sound = sound;
                this.show = show;
                this.desc = desc;
                this.history = history;

            }

            public void Sound()
            {
                Console.WriteLine($" Sound: {sound}");
            }

            public void Show()
            {
                Console.WriteLine($" Name: {show}");
            }

            public void Desc()
            {
                Console.WriteLine($" Description: {desc}");
            }

            public void History()
            {
                Console.WriteLine($" History: {history}");
            }
        }

        public class Trombone : Musical_instruments
        {
            public string sound { get; set; }
            public string show { get; set; }
            public string desc { get; set; }
            public string history { get; set; }

            public Trombone(string sound, string show, string desc, string history) : base(name, description)
            {
                this.sound = sound;
                this.show = show;
                this.desc = desc;
                this.history = history;

            }
            public void Sound()
            {
                Console.WriteLine($"Sound: {sound}");
            }

            public void Show()
            {
                Console.WriteLine($"Name: {show}");
            }

            public void Desc()
            {
                Console.WriteLine($"Description: {desc}");
            }

            public void History()
            {
                Console.WriteLine($"History: {history}");
            }
        }

        public class Ukulele : Musical_instruments
        {


            public string sound { get; set; }
            public string show { get; set; }
            public string desc { get; set; }
            public string history { get; set; }


            public Ukulele(string sound, string show, string desc, string history) : base(name, description)
            {
                this.sound = sound;
                this.show = show;
                this.desc = desc;
                this.history = history;

            }
            public void Sound()
            {
                Console.WriteLine($"Sound: {sound}");
            }

            public void Show()
            {
                Console.WriteLine($"Name: {show}");
            }

            public void Desc()
            {
                Console.WriteLine($"Description: {desc}");
            }

            public void History()
            {
                Console.WriteLine($"History: {history}");
            }

        }
        public class Cello : Musical_instruments
        {
            public string sound { get; set; }
            public string show { get; set; }
            public string desc { get; set; }
            public string history { get; set; }

            public Cello(string sound, string show, string desc, string history) : base(name, description)
            {
                this.sound = sound;
                this.show = show;
                this.desc = desc;
                this.history = history;

            }
            public void Sound()
            {
                Console.WriteLine($"Sound: {sound}");
            }

            public void Show()
            {
                Console.WriteLine($"Name: {show}");
            }

            public void Desc()
            {
                Console.WriteLine($"Description: {desc}");
            }

            public void History()
            {
                Console.WriteLine($"History: {history}");
            }
        }
    }
}
