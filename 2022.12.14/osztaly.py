class Konyv:
    def __init__(self,cim,oldal,mufaj):
        self.cim=cim
        self.oldal=oldal
        self.mufaj=mufaj

print("könyvbevevő ")
a=Konyv(input("Cím: "), int(input("Oldalak: ")), input("Műfaj: "))
print(a.cim)
print(a.oldal)
print(a.mufaj)

