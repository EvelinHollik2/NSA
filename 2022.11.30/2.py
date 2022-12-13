#def Be():
#    print("Jolán")
#    return 5
#a=Be()
#print(a)

def MagasE(mag):
    if mag>170:
        return True
    else:
        return False

nev=input("Név: ")
while (nev!=""):
    m=int(input("Magasság: "))
    if MagasE(m):
        print(nev,"magasabb, mint az átlag!")
    else:
        print(nev,"nem magasabb, mint az átlag!")
    nev=input("Név: ")
