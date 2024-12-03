#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int a,c;
	//printf("%d\n",a=5);
	//printf("%d",a==5);//因為上面一行，a=5,邏輯成立是1; 
	//printf("%d",a!=5);//邏輯不成立1;
	//int b=0;
	//a=!b;
	//c=!a;
	//printf("%d %d\n",a,c);
	//printf("%d ",a=!a);
	
	//int d;
	//printf("\n%d",d=12%(-7));	
//	printf("\n%d",d=-12%7);
//printf("\n%d",d=-12%-7);
	
	//int e;
	//if(e=1)printf("\n執行");printf("%d",e); 
	//if(e=3)printf("\n執行");printf("%d",e); 
	//if(1)printf("\n執行");
	  //printf("%d",e); 
	//if(3)
	  //printf("\n3執行");//非零都成立 
	  //printf("%d",e); 
	//if(0)
	  //printf("\n0執行");
	  //printf("0%d",e);  
	//if(-5)
	  //printf("\n-5執行");  
	  //printf("%d",e); 	
	//考試寫3==a; 
	
	//int aa=0;
	//printf("\naa=%d\n%d %d %d",aa,aa++,aa++,aa++);
	//int bb=0;
	//printf("\nbb=%d\n%d %d %d",bb,++bb,++bb,++bb);
	//int cc=0;
	//printf("\ncc=%d\n%d %d %d",cc,++cc,cc++,++cc);
	//cc=0;
	//printf("\n%d %d %d\ncc=%d",++cc,++cc,cc++,cc);
	
	int ac=1234,i=0,k=1;
	char ch[10];
	while(ac>=k){
		i++;
		k=k*16;
	}
	printf("\n%d\n",i);
	ch[i]="\0";
	i--;
	int mod;
	while(i>=0){
		mod=a%16;
		if(mod>=10){
			ch[i]=mod+'a'-10;}
		if(mod<10){
			ch[i]=mod+'0';}
		a=a/16;
		i--;
	}
	printf("\n%s\n",ch);


	return 0;
}
