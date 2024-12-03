/* prog8_2, ¨Ï¥Îadd()¨ç¼Æ */
#include <stdio.h>
#include <stdlib.h>
int Add(int,int);
int Sub(int,int);
int Mpy(int,int);
int Div(int,int);
int Ren(int,int);
int main(void)
{
   int x,y;
   char ch;
   scanf("%d%c%d",&x,&ch,&y);
   
   switch(ch){
   	case '+':
   		printf("%d%c%d=%d",x,ch,y,Add(x,y));
   		break;
	case '-':
   		printf("%d%c%d=%d",x,ch,y,Sub(x,y));
   		break; 
	case '*':
   		printf("%d%c%d=%d",x,ch,y,Mpy(x,y));
   		break;
   	case '/':
   		printf("%d%c%d=%d",x,ch,y,Div(x,y));
   		break;
   	case '%':
   		printf("%d%c%d=%d",x,ch,y,Ren(x,y));
   		break;
   }
   
   return 0;
}

int Add(int num1, int num2) {
   int a; 					
   a=num1+num2;
   return a; 				
}
int Sub(int num1,int num2){
   int a; 					
   a=num1-num2;
   return a; 
} 
int Mpy(int num1,int num2){
   int a; 					
   a=num1*num2;
   return a; 
} 
int Div(int num1,int num2){
   int a; 					
   a=num1/num2;
   return a; 
} 
int Ren(int num1,int num2){
   int a; 					
   a=num1%num2;
   return a; 
} 




