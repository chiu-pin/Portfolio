#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
/*	int numone,numtwo;
	printf("數字一：");
	scanf(" %d",&numone);
	fflush(stdin);
	printf("數字二：");
	scanf(" %d",&numtwo);
	fflush(stdin);
	if(numone>numtwo)
		printf("%d大於%d",numone,numtwo);
	else if(numone<numtwo)
		printf("%d小於%d",numone,numtwo);
		else //不加條件式 
		printf("%d等於%d",numone,numtwo);
	
	int num1,num2,larger;
	printf("\n請輸入兩個整數:");
	scanf("%d %d",&num1,&num2);
   
	larger=num1>num2 ? (num1) : (num2);  /* 條件運算子 */
	/*printf("%d數值較大\n",larger);*/
   /*int a,b;
   char oper;
   printf("請輸入運算式(例如:3+2): ");   	
   scanf("%d %c %d",&a,&oper,&b);

   switch(oper)
   {
      case '+':
         printf("%d+%d=%d\n",a,b,a+b);	
         break;
      case '-':
         printf("%d-%d=%d\n",a,b,a-b);		
         break;
      case '*':
         printf("%d*%d=%d\n",a,b,a*b);		
         break;
      case '/':
         printf("%d/%d=%.3f\n",a,b,(float)a/b); 
         break;
       case '%':
         printf("%d%%%d=%d\n",a,b,a%b); 
         break;   
      default:
         printf("無法辨認的運算式!!\n");		印出字串 */
   //}
   /*int a;
    	
   scanf("%d",&a);
   switch(a%3)
   {
      case 0:
         printf("%d%%%d=%d,是3的倍數",a,b,a%b);	
         break;
      case 1:
         printf("%d%%%d=%d,餘數唯%d",a,b,a%b,a%b);	
         break;
      case 2:
         printf("%d%%%d=%d,餘數唯%d",a,b,a%b,a%b);
         break;
      default:
         printf("無法辨認的運算式!!\n");
	}
   system("pause");*/
   /*+
   int a;
   scanf("%d",&a);
   switch(a)
   {
      case 9:
         printf("*********\n");	
      case 8:
         printf("********\n");	
         case 7:
         printf("*******\n");	
      case 6:
         printf("******\n");
	  case 5:
         printf("*****\n");	
      case 4:
         printf("****\n");	
      case 3:
         printf("***\n");
      case 2:
         printf("**\n");
      case 1:
         printf("*\n");	
      default:
         printf("無法辨認!!\n");
	}*/
	int grade;
	scanf("%d",&grade);
	switch(grade)
   {
      case 0 ... 9: //零後要空格九前要空格 
           printf("%d在0~9\n",grade);
      break; 
      case 10 ... 19: 
           printf("%d在10~19\n",grade);
      break; 
      case 20 ... 29:
           printf("%d在20~29\n",grade);
      break; 
	  case 30 ... 39:
        printf("%d在30~39\n",grade);
      break; 
      case 40 ... 49:
        printf("%d在40~49\n",grade);
	  break; 	
      case 50 ... 59:
         printf("%d在50~59\n",grade);
      break; 
      case 60 ... 69:
         printf("%d在60~69\n",grade);
      break; 
      case 70 ... 79:
         printf("%d在70~79\n",grade); 
	  break;  
      case 80 ... 89:
	     printf("%d在80~89\n",grade);
	  break; 
      case 90 ... 99:
      	printf("%d在90~99\n",grade);
      break; 
      case 100:
        printf("%d為一百",grade);
      break; 
      default:
         printf("超出範圍\n");
	}	
	
	return 0;
}
