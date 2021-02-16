   using System.Collections.Generic;

    public class Condition    {
        public string text { get; set; } 
        public string icon { get; set; } 
        public int code { get; set; } 
    }

    public class Current {
        public string last_updated { get; set; } 
        public double temp_c { get; set; } 
        public double temp_f { get; set; } 
        public Condition condition { get; set; }
    }

    public class Root {
        public Current current { get; set; }
    }
