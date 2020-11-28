import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from matplotlib import cm
from psycopg2 import sql
from bs4 import BeautifulSoup
import requests as req   


resp = req.get("https://заводы.рф/factories?page=0")
soup = BeautifulSoup(resp.text, 'html.parser')
results = soup.findAll("div", { "class" : "factory__head" })

for result in results :
        if len(result['class']) == 1:
            print(result)