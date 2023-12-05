using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopingApp.Models;

namespace ShopingApp.ViewModel
{
    public class LaptopViewModel
    {
        private ObservableCollection<Model> laptopInfo;

        public ObservableCollection<Model> LaptopInfo
        {
            get { return laptopInfo; }
            set { this.laptopInfo = value; }
        }

        public LaptopViewModel()
        {
            GenerateLaptopInfo();
        }

        internal void GenerateLaptopInfo()
        {
            laptopInfo = new ObservableCollection<Model>();
            laptopInfo.Add(new Model() { Name = "Macbook air m1", Description = "Object-oriented programming is a programming paradigm based on the concept of objects", image = "laptop.png", price = 56 });
            laptopInfo.Add(new Model() { Name = "Leonovo Legion", Description = "Code Contracts provide a way to convey code assumptions", image = "laptop.png", price = 56 });
            laptopInfo.Add(new Model() { Name = "HP Pavilion", Description = "You will learn several different approaches to applying machine learning", image = "laptop.png", price = 56 });
            laptopInfo.Add(new Model() { Name = "Hp Victus", Description = "Neural networks are an exciting field of software development", image = "laptop.png", price = 56 });
        }
    }
}
