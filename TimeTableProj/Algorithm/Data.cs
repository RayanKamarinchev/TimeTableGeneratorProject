using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTimeTable.Models;

namespace MyTimeTable
{
    public class Data
    {
        public List<Class> classes;
        public List<Teacher> teachers;

        public object Fill()
        {
            const string bg = "Бг";
            const string math = "Мат";
            const string ae = "Анг";
            const string mus = "Муз";
            const string it = "ИТ";
            const string inf = "Инф";
            const string phil = "Фил";
            const string pe = "ФВС";
            const string bio = "Био";
            const string chem = "Хим";
            const string phys = "Физ";
            const string his = "Ист";
            const string geo = "Гео";
            //INPUT
            //8
            Dictionary<string, int> class8h = new Dictionary<string, int>();
            class8h.Add(math, 3);
            class8h.Add(bg, 4);
            class8h.Add(ae, 18);
            class8h.Add(mus, 1);
            class8h.Add(it, 1);
            class8h.Add(inf, 2);
            class8h.Add(phil, 1);
            class8h.Add(pe, 2);

            Class a8 = new Class("8а", class8h);
            Class b8 = new Class("8б", class8h);
            Class c8 = new Class("8в", class8h);
            Class d8 = new Class("8г", class8h);
            Class e8 = new Class("8д", class8h);

            //10
            Dictionary<string, int> class10h = new Dictionary<string, int>();

            class10h.Add(bg, 4);
            class10h.Add(ae, 4);
            class10h.Add(math, 3);
            class10h.Add(bio, 2);
            class10h.Add(chem, 2);
            class10h.Add(geo, 2);
            class10h.Add(his, 3);
            class10h.Add(mus, 1);
            class10h.Add(it, 1);
            class10h.Add(phil, 2);
            class10h.Add(pe, 2);
            class10h.Add(phys, 2);

            class10h[bio] += 2;
            class10h[chem] += 2;
            Class a10 = new Class("10а", class10h);
            Class b10 = new Class("10б", class10h);
            class10h[bio] -= 2;
            class10h[chem] -= 2;
            class10h[math] += 2;
            class10h.Add(inf, 2);
            Class c10 = new Class("10в", class10h);
            Class d10 = new Class("10г", class10h);
            class10h[math] -= 2;
            class10h[it] += 2;
            Class e10 = new Class("10д", class10h);

            //12
            Dictionary<string, int> class12h = new Dictionary<string, int>();

            class12h.Add(bg, 5);
            class12h.Add(ae, 7);
            class12h.Add(math, 3);
            class12h.Add(phil, 2);
            class12h.Add(pe, 2);

            class12h.Add(bio, 6);
            class12h.Add(chem, 7);
            Class a12 = new Class("12а", class12h);
            Class b12 = new Class("12б", class12h);
            class12h.Remove(bio);
            class12h.Remove(chem);
            class12h[math] += 7;
            class12h.Add(inf, 6);
            Class c12 = new Class("12в", class12h);
            Class d12 = new Class("12г", class12h);
            class12h[math] -= 7;
            class12h[inf] += 1;
            class12h.Add(it, 6);
            Class e12 = new Class("12д", class12h);
            class12h.Remove(inf);
            class12h.Add(geo, 7);
            Class f12 = new Class("12е", class12h);

            classes = new List<Class>() { a8, b8, c8, d8, e8, a10, b10, c10, d10, e10, a12, b12, c12, d12, e12, f12 };
            teachers = new List<Teacher>()
                {
                    new Teacher(new List<Class>
                    {
                        a8
                    }, ae, "Margarita"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, e8, a10, b10, c10, d10, e10
                    }, math, "Walters"),
                    new Teacher(new List<Class>
                    {
                        b8
                    }, ae, "Morgan"),
                    new Teacher(new List<Class>
                    {
                        a8, c8, b8, d8, e8
                    }, inf, "Daniels"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, d8, c8, e8
                    }, inf, "Cassidy"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, c8, d8, e8, a10, b10, c10, d10, e10
                    }, "Mus", "Dimitrova"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, c8, d8, e8
                    }, pe, "Weaver"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, c8
                    }, bg, "Penchev"),
                    new Teacher(new List<Class>
                    {
                        d8, e8
                    }, bg, "Borislavov"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, c8, d8, e8
                    }, it, "Leonard"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, c8, d8, e8
                    }, it, "Mr. Information"),
                    new Teacher(new List<Class>
                    {
                        a8, b8, c8, d8, e8, a10, b10, c10, d10, e10
                    }, phil, "Stoqnov"),
                    new Teacher(new List<Class>
                    {
                        c12, d12, e12, f12
                    }, phil, "Howard"),
                    new Teacher(new List<Class>
                    {
                        c8
                    }, ae, "Gordon"),
                    new Teacher(new List<Class>
                    {
                        c12, d12, e12
                    }, inf, "Borisov"),
                    new Teacher(new List<Class>
                    {
                        c8, d8, a12
                    }, math, "Ruseva"),
                    new Teacher(new List<Class>
                    {
                        c12, d12, e12
                    }, math, "Blagoeva"),
                    new Teacher(new List<Class>
                    {
                        d8
                    }, ae, "Radev"),
                    new Teacher(new List<Class>
                    {
                        e8
                    }, ae, "Gavrilova"),
                    new Teacher(new List<Class>
                    {
                        a10, c10
                    }, bg, "Pencheva"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, pe, "Cvetan"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, his, "Radulova"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, bio, "Dobreva"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, chem, "Filipova"),
                    new Teacher(new List<Class>
                    {
                        a10, b10
                    }, ae, "Nakov"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, it, "Hristov"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, it, "Nikolov"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10
                    }, phys, "Marinova"),
                    new Teacher(new List<Class>
                    {
                        a10, b10, c10, d10, e10, f12
                    }, geo, "Mladenov"),
                    new Teacher(new List<Class>
                    {
                        b10, e10
                    }, bg, "Simeonova"),
                    new Teacher(new List<Class>
                    {
                        d10
                    }, bg, "Ivankova"),
                    new Teacher(new List<Class>
                    {
                        c10
                    }, ae, "Popova"),
                    new Teacher(new List<Class>
                    {
                        d10, e10
                    }, ae, "Stankova"),
                    new Teacher(new List<Class>
                    {
                        c10, d10, e10
                    }, inf, "Dineva"),
                    new Teacher(new List<Class>
                    {
                        c10, d10, e10
                    }, inf, "Mihailov"),
                    new Teacher(new List<Class>
                    {
                        a12, b12, c12, d12, e12, f12
                    }, pe, "Todorov"),
                    new Teacher(new List<Class>
                    {
                        a12, b12, d12, e12
                    }, bg, "Stoev"),
                    new Teacher(new List<Class>
                    {
                        c12, f12
                    }, bg, "Koleva"),
                    new Teacher(new List<Class>
                    {
                        a12, c12
                    }, ae, "Valeriev"),
                    new Teacher(new List<Class>
                    {
                        b12, d12
                    }, ae, "Strahilov"),
                    new Teacher(new List<Class>
                    {
                        b12, f12
                    }, math, "Petrov"),
                    new Teacher(new List<Class>
                    {
                        a12, b12
                    }, bio, "Stefanova"),
                    new Teacher(new List<Class>
                    {
                        a12, b12
                    }, phil, "Tanev"),
                    new Teacher(new List<Class>
                    {
                        a12, b12
                    }, chem, "Vulchev"),
                    new Teacher(new List<Class>
                    {
                        e12, f12
                    }, ae, "Tsvetkova"),
                    new Teacher(new List<Class>
                    {
                        c12
                    }, inf, "Hadjiev"),
                    new Teacher(new List<Class>
                    {
                        c12, d12, e12
                    }, inf, "Ganev"),
                    new Teacher(new List<Class>
                    {
                        e12, f12
                    }, it, "Penchev"),
                    new Teacher(new List<Class>
                    {
                        e12, f12
                    }, it, "Pramatarova"),
                };
            return teachers.Select(t => new
            {
                t.Name,
                t.Subject,
                classes = t.classes.Select(c => c.Name).ToList()
            });
        }
    }
}
