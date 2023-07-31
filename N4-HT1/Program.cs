using static System.Net.Mime.MediaTypeNames;

string Essey = "Lorem ipsum dolor sit amet consectetur adipisicing elit." +
    " quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus" +
    " inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum." +
    " Numquam rem alias minima culpa iste distinctio. Eum similique est" +
    " consequuntur minus, odio nisi recusandae iure asperiores facere," +
    " reiciendis voluptate maiores! Repellat, dolorum!";

/*
Essay analiz qiladigan dastur tuzing. 

Boshlang'ich 100 ball bilan boshlab, har bitta xato uchun quyidagicha minus qilib borasiz

- Berilgan jumlani xohlagancha qismlarga ajrating ( gap, so'z va hk ) va quyidagilarni tekshiring
- Umumiy so'zlar soni 500 dan kam bo'lsa - 5 ball
- Xohlagan bitta so'z takrorlanishi umumiy so'zlar sonini 20% dan ko'pini tashkil qilsa - 5 ball
- Gapda 1-so'z capital bo'lmasa - 5 ball
- Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball
- Gapda so'zlar uzunligi 20 dan oshib ketgan bo'lsa - 20 ball
*/


var ball = 100;


for (int i = 0; i < Essey.Length; i++)
{
    if (Essey.Length < 500)
    {
        ball -= 5;
    }
    
}
