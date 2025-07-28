import csv
from decimal import Decimal

with open("messages.tsv") as file:
    tsv_file = csv.reader(file, delimiter="\t")
    for line in tsv_file:
        print("new Message(\"%s\",%s,%s,%s,%s,\"\")," % (line[0], line[1], line[2], line[3], line[4]))
