#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;
char a[101][101],b[101][101],c[101][101],d[101][101],e[101][101],f[101][101],g[101][101],z[101][101];
int i,j,h,p,x,k=11,aicastigat=1;
char a1='Â',a2='Â',a3='Â',a4='Â',a5='0',a6='x',a7='Â',y='+';
int o1,o2,o3,o4;
void desencasuta(char a[101][101],int y,int k);
void null(char a[101][101])
{
for(i=2;i<k;i++)
            for(j=2;j<k;j++)a[i][j]=' ';
}
void unu(char a[101][101])
{
for(i=3;i<k;i++)
    a[i][k-3]=y;
    for(i=3;i<k;i++)
        for(j=3;j<k;j++)
        if(k-i-j==0)a[i-1][j]=y;
}
void doi(char a[101][101])
{
for(i=3;i<k-4;i++)
    a[i][k-2]=y;
    for(i=k-5;i<k-1;i++)
    a[i][3]=y;
for(i=3;i<k-1;i++)
    a[2][i]=a[2+4][i]=a[2+8][i]=y;
}
void trei(char a[101][101])
{
for(i=3;i<k-1;i++)
    a[i][k-2]=y;

for(i=3;i<k-1;i++)
    a[2][i]=a[2+4][i]=a[2+8][i]=y;
}
void patru(char a[101][101])
{
for(i=2;i<k;i++)
    a[i][k-2]=y;
    for(i=2;i<k-5;i++)
    a[i][3]=y;
for(i=3;i<k-1;i++)
    a[2+4][i]=y;
}

void situatie(int y,int ok,int &aicastigat)
{
    if(ok==0){desencasuta(f,y-k/2,k/2);desencasuta(f,y-k/2,k/2);desencasuta(f,y-k/2,k/2);desencasuta(f,y-k/2,k/2);}
  else  if(ok==1){desencasuta(e,y-k/2,k/2);desencasuta(f,y-k/2,k/2);desencasuta(f,y-k/2,k/2);desencasuta(f,y-k/2,k/2);}
else if(ok==2){desencasuta(e,y-k/2,k/2);desencasuta(e,y-k/2,k/2);desencasuta(f,y-k/2,k/2);desencasuta(f,y-k/2,k/2);}
else if(ok==3){desencasuta(e,y-k/2,k/2);desencasuta(e,y-k/2,k/2);desencasuta(e,y-k/2,k/2);desencasuta(f,y-k/2,k/2);}
else if(ok==4){desencasuta(e,y-k/2,k/2);desencasuta(e,y-k/2,k/2);desencasuta(e,y-k/2,k/2);desencasuta(e,y-k/2,k/2),aicastigat=0;}


}
void formacasuta(char a[101][101],char caracter,int k)
{
    for(i=1;i<=k;i++)
        a[1][i]=a[i][1]=a[k][i]=a[i][k]='|';
       if(caracter=='1')null(a),unu(a);
       else
       if(caracter=='2')null(a),doi(a);
       else
       if(caracter=='3')null(a),trei(a);
       else
       if(caracter=='4')null(a),patru(a);
       else{for(i=2;i<k;i++)
            for(j=2;j<k;j++)a[i][j]=caracter;}
}
void desencasuta(char a[101][101],int y,int k)
{
    for(i=1;i<=k;i++)
cout<<a[y][i];
cout<<" ";
}
void construieste()
{
formacasuta(g,a7,k);
    formacasuta(a,a1,k);
formacasuta(b,a2,k);
formacasuta(c,a3,k);
formacasuta(d,a4,k);
formacasuta(e,a5,k/2);
formacasuta(f,a6,k/2);
}
void deseneaza(int ok,int h)
{
int y;
    for(y=1;y<=k;y++)
{cout<<"  ";
desencasuta(a,y,k);
desencasuta(b,y,k);
desencasuta(c,y,k);
desencasuta(d,y,k);
if(y>=k/2)situatie(y,ok,aicastigat);
cout<<endl;}
if(aicastigat==0)cout<<"FELICITARI AI CASTIGAT   "<<"Numar incercari = "<<h;
}
void atribuie(int a,char &s)
{int g=a;
    if(g==1)s='1';
    else if(g==2)s='2';
    else if(g==3)s='3';
    else if(g==4)s='4';
}
void atribuie1()
{

srand(static_cast<unsigned int>(time(0)));
o1=rand()%10;if(o1>4)o1=o1/2;if(o1==0)o1++;
o2=rand()%10;if(o2>4)o2=o2/2;if(o2==0)o2++;
o3=rand()%10;if(o3>4)o3=o3/2;if(o3==0)o3++;
o4=rand()%10;if(o4>4)o4=o4/2;if(o4==0)o4++;
atribuie(o1,a1);
atribuie(o2,a2);
atribuie(o3,a3);
atribuie(o4,a4);
}
void  citeste(int ok,int h)
{
    int sol1,sol2,sol3,sol4;
cin>>sol1>>sol2>>sol3>>sol4;
if(sol1==o1)ok++;
if(sol2==o2)ok++;
if(sol3==o3)ok++;
if(sol4==o4)ok++;
atribuie (sol1,a1);
atribuie (sol2,a2);
atribuie (sol3,a3);
atribuie (sol4,a4);
construieste();
deseneaza(ok,h);
}
int main()
{int ok=0,incercari=0;
    construieste();
deseneaza(0,1);
atribuie1();
while(aicastigat)
incercari++,citeste(ok,incercari);


return 0;
}

