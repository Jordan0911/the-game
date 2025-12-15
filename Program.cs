namespace the_game
{
    internal class Program
    {
        static string Weaver_roll(string[] silk_skills,string eq_ss)
        {
            string new_ss = "";
            Random rand = new Random();
            int s = 0;
            string[] shop_items = new string[3];
            for (int i = 0; i < shop_items.Length; i++)
            {
                s = rand.Next(silk_skills.Length);
                if (silk_skills[s] == eq_ss)
                {
                    i--;
                }
                else
                {
                    new_ss = silk_skills[s];
                }
            }
            return new_ss;
        }
        static string[] Sly(string[] shop_charms)
        {
            Random rand=new Random();
            int s = 0;
            string[] shop_items= new string[3];    
            for (int i = 0; i < shop_items.Length; i++)
            {
                s =rand.Next(shop_charms.Length);
               if (shop_charms[s] == "")
               {
                    i--;
               }
                else
                {
                    shop_items[i] = shop_charms[s];
                }
            }
            return shop_items;
        }
        static int[] Bench(int[] hitpoints)
        {
            hitpoints[0] = 100;
            hitpoints[1] = 120;
            return hitpoints;
        }
        static void Main(string[] args)
        {
            string[] silk_skills = { "silk spear", "thread storm", "cross stich" };
            string[] boss_charms = { "stalwart shell" };
            string[] shop_charms = {"strenght","quick slash","heavy blow","soul catcher","soul eater","soul twister","shaman stone","quick focus","deep focus","shape of unn","greed","heart"};
            bool win = false;
            bool end = false;
            while (end=false)
            {
                int[] hitpoints = { 10, 12 };











                end = true;
            }
        }
    }
}
