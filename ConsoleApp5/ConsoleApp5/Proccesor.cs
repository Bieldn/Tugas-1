namespace hereProccesor
{
    class Proccesor
    {
        public string merk;
        public string tipe;

    }
    class Intel : Proccesor
    {
        public Intel()
        {
            merk = "Intel";
        }

    }
    class Amd : Proccesor
    {
        public Amd()
        {
            merk= "Amd";
        }
    }
    class Corei3 : Intel
    {
        public Corei3()
        {
            tipe = "Core I3";
        }
    }
    class Corei5 : Intel
    {
        public Corei5()
        {
            tipe = "core I5";
        }
    }
    class Corei7: Intel
    {
        public Corei7()
        {
            tipe = "core I7";

        }
    }
    class Rayzen : Amd
    {
        public Rayzen()
        {
            tipe = "Rayzen";

        } 
    }
    class Athlon : Amd
    {
        public Athlon()
        {
            tipe = "Athlon";
        }
    }
}