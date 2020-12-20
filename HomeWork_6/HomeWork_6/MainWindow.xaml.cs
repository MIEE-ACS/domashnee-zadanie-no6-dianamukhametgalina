using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public abstract class GardenPlant
        {
            public class GardenPlantException : Exception
            {
                public GardenPlantException(string message)
                    : base(message)
                { }
            }
            public override string ToString()
            {
                return "Садовое растение, ";
            }
        }

        public class Vegetable : GardenPlant
        {
            public override string ToString()
            {
                return base.ToString() + "овощ: ";
            }
        }

        public abstract class FruitTree : GardenPlant
        {
            public override string ToString()
            {
                return base.ToString() + "фруктовое дерево: ";
            }
        }

        public abstract class Berry : GardenPlant
        {
            public override string ToString()
            {
                return base.ToString() + "ягода: ";
            }
        }

        public partial class Potato : Vegetable
        {
            string m_name = "Картошка"; // название растения
            string m_color;
            string m_plantVariety; // сорт растения
            int m_yield; // урожайность 
            int m_ripeningTime; // время созревания (в днях)
            public string Color
            {
                get
                {
                    return m_color;
                }
                set
                {
                    m_color = value;
                }
            }
            public string PlantVariety
            {
                get
                {
                    return m_plantVariety;
                }
                set
                {
                    m_plantVariety = value;
                }
            }
            public int Yield
            {
                get
                {
                    return m_yield;
                }
                set
                {
                    if (value <= 0)
                        throw new GardenPlantException("YieldException");
                    m_yield = value;
                }
            }
            public int RipeningTime
            {
                get
                {
                    return m_ripeningTime;
                }
                set
                {
                    if (value <= 0)
                        throw new GardenPlantException("RepiningTimeException");
                    m_ripeningTime = value;
                }
            }
            public Potato(string plantVar, string color, int yield, int ripeningTime)
            {
                PlantVariety = plantVar;
                Color = color;
                Yield = yield;
                RipeningTime = ripeningTime;
            }
            public override string ToString()
            {
                return base.ToString() + $"{m_name} {m_plantVariety}\nЦвет плода: {m_color}\nУрожайность: {m_yield}\nВремя созревания: {m_ripeningTime}";
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                Potato g = obj as Potato;
                if (g as Potato == null)
                    return false;
                return g.m_color == this.m_color && g.m_yield == this.m_yield && g.m_ripeningTime == this.m_ripeningTime && g.m_plantVariety == this.m_plantVariety;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        public partial class AppleTree : FruitTree
        {
            string m_name = "Яблоня"; // название растения
            string m_color;
            string m_plantVariety; // сорт растения
            int m_yield; // урожайность 
            int m_ripeningTime; // время созревания (в днях)
            public string Color
            {
                get
                {
                    return m_color;
                }
                set
                {
                    m_color = value;
                }
            }
            public string PlantVariety
            {
                get
                {
                    return m_plantVariety;
                }
                set
                {
                    m_plantVariety = value;
                }
            }
            public int Yield
            {
                get
                {
                    return m_yield;
                }
                set
                {
                    if (value <= 0)
                        throw new GardenPlantException("YieldException");
                    m_yield = value;
                }
            }
            public int RipeningTime
            {
                get
                {
                    return m_ripeningTime;
                }
                set
                {
                    if (value <= 0)
                        throw new GardenPlantException("RepiningTimeException");
                    m_ripeningTime = value;
                }
            }
            public AppleTree(string plantVar, string color, int yield, int ripeningTime)
            {
                PlantVariety = plantVar;
                Color = color;
                Yield = yield;
                RipeningTime = ripeningTime;
            }
            public override string ToString()
            {
                return base.ToString() + $"{m_name} {m_plantVariety}\nЦвет плода: {m_color}\nУрожайность: {m_yield}\nВремя созревания: {m_ripeningTime}";
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                AppleTree g = obj as AppleTree;
                if (g as AppleTree == null)
                    return false;
                return g.m_color == this.m_color && g.m_yield == this.m_yield && g.m_ripeningTime == this.m_ripeningTime && g.m_plantVariety == this.m_plantVariety;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        public partial class Raspberry : Berry
        {
            string m_name = "Малина"; // название растения
            string m_color;
            string m_plantVariety; // сорт растения
            int m_yield; // урожайность 
            int m_ripeningTime; // время созревания (в днях)
            public string Color
            {
                get
                {
                    return m_color;
                }
                set
                {
                    m_color = value;
                }
            }
            public string PlantVariety
            {
                get
                {
                    return m_plantVariety;
                }
                set
                {
                    m_plantVariety = value;
                }
            }
            public int Yield
            {
                get
                {
                    return m_yield;
                }
                set
                {
                    if (value <= 0)
                        throw new GardenPlantException("YieldException");
                    m_yield = value;
                }
            }
            public int RipeningTime
            {
                get
                {
                    return m_ripeningTime;
                }
                set
                {
                    if (value <= 0)
                        throw new GardenPlantException("RepiningTimeException");
                    m_ripeningTime = value;
                }
            }
            public Raspberry(string plantVar, string color, int yield, int ripeningTime)
            {
                PlantVariety = plantVar;
                Color = color;
                Yield = yield;
                RipeningTime = ripeningTime;
            }
            public override string ToString()
            {
                return base.ToString() + $"{m_name} {m_plantVariety}\nЦвет плода: {m_color}\nУрожайность: {m_yield}\nВремя созревания: {m_ripeningTime}";
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                Raspberry g = obj as Raspberry;
                if (g as Raspberry == null)
                    return false;
                return g.m_color == this.m_color && g.m_yield == this.m_yield && g.m_ripeningTime == this.m_ripeningTime && g.m_plantVariety == this.m_plantVariety;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        List<GardenPlant> Plants = new List<GardenPlant>()
            {
                new Potato("Белая роза", "Коричневый", 5, 10),
                new AppleTree("Антоновка", "Зеленый", 666, 1337),
                new Raspberry("Геракл", "красный", 228, 1482)
            };
       
        public MainWindow()
        {
            InitializeComponent();
            UpdatePlantsList();
        }
        public void UpdatePlantsList()
        {
            lbPlants.Items.Clear();
            foreach (var plant in Plants)
            {
                lbPlants.Items.Add(plant);
            }
        }

    }
}
