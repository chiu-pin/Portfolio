#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	//char ch1,ch2,ch3;	//printf("ch1=");	//scanf(" %c",&ch1);	//printf("ch2=");//scanf(" %c",&ch2);//printf("ch3=");	//scanf(" %c",&ch3);
	//scanf連續輸入 加空白 system("pause");
	//int num1,num2,num3;//num1=ch1-'0';//num2=ch2-'0';//num3=ch3-'0';

	//int num,num100,num10,num1;
	//printf("請輸入三位數");
	//scanf("%d",&num);
	//if(num<=999){	
	//num100=num/100;
	//num10=(num-num100*100)/10;
	//num1=num-num100*100-num10*10;
	//printf("數字%d,百位%d,十位數%d,個位數%d",num,num100,num10,num1);}
    //else printf("輸入錯誤");
	
	//getch()以及回聲getche()
	
	//float num1=123.456789012345f;//double num2=123.456789012345;
	//printf("num1=%16.12f\n",num1);//printf("num2=%16.12f\n",num2);
	//char ch;
	//printf("sizeof(22)=%d\n",sizeof(22));	//printf("sizeof(789.99567)=%d\n",sizeof(789.99567f));	
	//printf("sizeof(123.456789012345)=%d\n",sizeof(123.456789012345));//printf("sizeof(double)=%d\n",sizeof(double));		//printf("sizeof(float)=%d\n",sizeof(float));
	//printf("sizeof(long long)=%d\n",sizeof(long long));
	//printf("sizeof(long)=%d\n",sizeof(long));
	//printf("sizeof(short int)=%d\n",sizeof(short int));
	//printf("sizeof(short)=%d\n",sizeof(short));
	
	/*必考四捨五入*/ /*特殊符號輸入必考*/ 
	int n1,n2,n3,n4;
	float num1=13.002f,num2=18.988f;
	float f1,f2;
	n1=(int) (num1/10+0.5)*10;
	n2= (int)(num2/10+0.5)*10;
	f1=(float)((int)(num1*10.0+0.5))/10;
	f2=((int)(num2*10+0.5))/10.0;

	printf("num1=%f, num2=%f\n",num1,num2);
	printf("n1=%d, n2=%d\n",n1,n2);
	printf("f1=%f, f2=%f\n",f1,f2);
	system("pause");
	
	return 0;
}
