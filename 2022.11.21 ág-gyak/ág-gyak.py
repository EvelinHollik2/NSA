#negativ.py
#a=int(input("A: "))
#b=int(input("B: "))
#
#if a<0 and b<0:
#    print("Mindkét szám negatív")
#elif a>0 and b>0:
#    print("Egyik sem negatív")
#elif a<0:
#    print("Az első szám negatív")
#elif b<0:
#    print("A második szám negatív")

#konyv.py
def HoE(a):
    b=False
    if a>150:
        b=True
    return b

cim=input("Cim:")
while(cim!=""):
    oldal=int(input("oldalak: "))
    old=HoE(oldal)
    if old:
        print("A könyv hosszú")
    else:
        print("A könyv rövid")
    cim=input("cim")