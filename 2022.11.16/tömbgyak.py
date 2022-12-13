import random
#Tömbös prog

#t=[1, 3, 5, 7, "jolán"]
#print(t)

#t=[]
#for i in range(5):
#    t.append(int(input("Adj számot ")))
#print(t)

t=[]
for i in range(5):
    t.append(random.randint(1,100))
print(t)

#Összegzés tétel
osszeg=0
for x in t:
    osszeg += x
print(osszeg("Az összege "))

#Átlag számítás
atl = osszeg/len(t)
print(atl("Az átlaga "))

#Min
min=101
for x in t:
    if min>x:
        min=x
print(min)
#Max
max=-1
for x in t:
    if max<x:
        max=x
print(max)

#keresés

