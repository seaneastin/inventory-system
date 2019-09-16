using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    delegate void Spell(Creature target);
    class SpellBook
    {
        public Spell Page1;
        public Spell Page2;
        public Spell[] book;

        public SpellBook(int pages)
        {
            Page1 = BlankPage;
            Page2 = BlankPage;

            book = new Spell[pages];
            for (int i = 0; i < pages; i++)
            {

            }
        }

        public void BlankPage(Creature target)
        {

        }
    }
}
