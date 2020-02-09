#include <iostream>
#include <fstream>
#include <cstring>
#include <ctime>
#include <cstdlib>
using namespace std;
ifstream o("animale.txt");
ofstream f("afara.txt");
int verif(char a[101],char b[101],int k,int n)
{int i,j,c=0;
   for(i=0;i<k;i++)
    for(j=0;j<n;j++)
    if(a[i]==b[j])c++,b[j]=' ',j=n;
   if(c==k)return 1;
    return 0;
}
void ordonare(char a[101],int k)
{int i,j,aux;
   for(i=0;i<k;i++)
    for(j=0;j<k;j++)
    if(a[i]<a[j]){aux=a[i];a[i]=a[j];a[j]=aux;}
}
int main()
{char a[101],b[101],c[101],d[101];
int n,g;
cin>>a;strcpy(d,a);
n=strlen(a);ordonare(a,n);
while (o>>b)
    {g=strlen(b),strcpy(c,b);ordonare(b,g);
        if(verif(b,a,g,n))f<<c<<"\n";strcpy(a,d);
    }
    return 0;
}

