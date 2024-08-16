namespace DataAccess
{
    public class Class1
    {
        //Deneme  Fonksiyonları
        public int col(int s1, int s2) 
        {          
            return s1 +s2;        
        }

        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        public double aort()
        {
            int toplam = 0;
            foreach (int i in list) 
            {
                toplam += i;
            }
            return toplam / list.Count;
            
        }
        
    }
}