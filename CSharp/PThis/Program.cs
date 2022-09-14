namespace PThis
{
    public class Computer
    {
        string CPU;
        string GPU;
        string MEMORY;
        string STORAGE;

        public Computer()
        {
            CPU = "i9-12900K";
            GPU = "RTX-3090";
            MEMORY = "16GB";
            STORAGE = "512GB";
        }

        public Computer(string CPU, string GPU, string MEMORY, string STORAGE)
        {
            this.CPU = CPU;
            this.GPU = GPU;
            this.MEMORY = MEMORY;
            this.STORAGE = STORAGE;
        }

        public Computer(string MEMORY, string STORAGE)
        {
            CPU = "i7-12900K";
            GPU = "RTX-3080";
            this.MEMORY = MEMORY;
            this.STORAGE = STORAGE;
        }

        public Computer(string STORAGE)
        {
            CPU = "i9-12900K";
            GPU = "RTX-3090";
            MEMORY = "16GB";
            this.STORAGE = STORAGE;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer All_IN_ONE = new Computer();
            Computer NOTE_BOOK = new Computer("16GB", "1TB");
            Computer DESKTOP = new Computer("I9-9900K", "RTX-3080", "32GB", "512GB");
        }
    }
}