#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
/*	int numone,numtwo;
	printf("�Ʀr�@�G");
	scanf(" %d",&numone);
	fflush(stdin);
	printf("�Ʀr�G�G");
	scanf(" %d",&numtwo);
	fflush(stdin);
	if(numone>numtwo)
		printf("%d�j��%d",numone,numtwo);
	else if(numone<numtwo)
		printf("%d�p��%d",numone,numtwo);
		else //���[���� 
		printf("%d����%d",numone,numtwo);
	
	int num1,num2,larger;
	printf("\n�п�J��Ӿ��:");
	scanf("%d %d",&num1,&num2);
   
	larger=num1>num2 ? (num1) : (num2);  /* ����B��l */
	/*printf("%d�ƭȸ��j\n",larger);*/
   /*int a,b;
   char oper;
   printf("�п�J�B�⦡(�Ҧp:3+2): ");   	
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
         printf("�L�k��{���B�⦡!!\n");		�L�X�r�� */
   //}
   /*int a;
    	
   scanf("%d",&a);
   switch(a%3)
   {
      case 0:
         printf("%d%%%d=%d,�O3������",a,b,a%b);	
         break;
      case 1:
         printf("%d%%%d=%d,�l�ư�%d",a,b,a%b,a%b);	
         break;
      case 2:
         printf("%d%%%d=%d,�l�ư�%d",a,b,a%b,a%b);
         break;
      default:
         printf("�L�k��{���B�⦡!!\n");
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
         printf("�L�k��{!!\n");
	}*/
	int grade;
	scanf("%d",&grade);
	switch(grade)
   {
      case 0 ... 9: //�s��n�Ů�E�e�n�Ů� 
           printf("%d�b0~9\n",grade);
      break; 
      case 10 ... 19: 
           printf("%d�b10~19\n",grade);
      break; 
      case 20 ... 29:
           printf("%d�b20~29\n",grade);
      break; 
	  case 30 ... 39:
        printf("%d�b30~39\n",grade);
      break; 
      case 40 ... 49:
        printf("%d�b40~49\n",grade);
	  break; 	
      case 50 ... 59:
         printf("%d�b50~59\n",grade);
      break; 
      case 60 ... 69:
         printf("%d�b60~69\n",grade);
      break; 
      case 70 ... 79:
         printf("%d�b70~79\n",grade); 
	  break;  
      case 80 ... 89:
	     printf("%d�b80~89\n",grade);
	  break; 
      case 90 ... 99:
      	printf("%d�b90~99\n",grade);
      break; 
      case 100:
        printf("%d���@��",grade);
      break; 
      default:
         printf("�W�X�d��\n");
	}	
	
	return 0;
}
