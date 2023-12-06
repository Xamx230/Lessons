int number = 161;
int lrp =7;
int drp = 23;

 if( number == 0){
        Console.WriteLine("Делить на 0 нельзя");
    }

if(number%lrp== 0 && number%drp==0){
    Console.WriteLine("Число кратно");
}
else
{
   if(number%lrp>0 && number%drp>0){
        Console.WriteLine($"Число {number} не кратно {lrp} и {drp}");
   }
}
