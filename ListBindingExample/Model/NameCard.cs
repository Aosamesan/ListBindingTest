using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBindingExample.Model
{
    public class NameCardList : ObservableCollection<NameCard>
    {

    }

    public class NameCard
    {
        public string Name { get; }
        public int Age { get; }
        public string Tag { get; }

        public NameCard(string name, int age, string tag)
        {
            Name = name;
            Age = age;
            Tag = tag;
        }
    }
}
