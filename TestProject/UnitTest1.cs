using AnimalsTask;

namespace TestProject
{
    public class Tests
    {
        [TestCase("������" , "�������� ���� �� ��� ������")]
        [TestCase("����", "�������� ���� ��� ����")]
        public static void Eat(string food, string expected)
        {
            Animals elephantPetya = new Animals("����", 18, "����", "������", 10, new string[] { "����", "������" }, "����");
            string actual = elephantPetya.Eat(food);
            Assert.AreEqual(expected, actual);
        }
         

        
    }

}