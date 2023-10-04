using AnimalsTask;

namespace TestProject
{
    public class Tests
    {
        [TestCase("Молоко" , "Животное Петя не ест Молоко")]
        [TestCase("Сено", "Животное Петя ест Сено")]
        public static void Eat(string food, string expected)
        {
            Animals elephantPetya = new Animals("Петя", 18, "Слон", "Африка", 10, new string[] { "Сено", "Бананы" }, "УУУУ");
            string actual = elephantPetya.Eat(food);
            Assert.AreEqual(expected, actual);
        }
         

        
    }

}