import random

class Szere:
    def __init__(self, nev, foglalkozas,nem,szam):
        self.nev=nev
        self.foglalkozas=foglalkozas
        self.nem=nem
        self.szam=szam
    
    def fvn(nem):
        if nem=="f":
            return "férfi"
        elif nem=="n":
            return "nő"

t=[]
for x in range(3):
    a=input("Add meg a nevet! ")
    b=input("Add meg a foglalkozást! ")
    c=input("Add meg a nemet! (f/n) ")
    d=random.randint(1,50)
    t.append(Szere(a,b,c,d))
for x in range(3):
    print(t[x].nev,"")

    