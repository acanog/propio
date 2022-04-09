import numpy as np
import pandas
import time
from pandas.core.frame import DataFrame
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as ec

excel_credenciales = r'E:\PABLO\SENA\programacion\Python\codigo\robot linkedin\credenciales.xlsx'

df = pandas.read_excel(excel_credenciales)

user = df['usuario'][0]
psw = df['contrasena'][0]


url = 'https://www.facebook.com/'

# Selectores:

#boton_inicio_sesion = 'body > nav > div > a.nav__button-secondary'
selector_usuario = '#email'
selector_contrasena = '#pass'
boton_login = '#u_0_h_me'

# Abrir navegador:

driver = webdriver.Chrome()

#Maximizar pantalla
driver.maximize_window()
driver.get(url)

#acciones en la pagina:

#driver.find_element_by_css_selector(boton_inicio_sesion).click()

# Loggearnos
driver.find_element_by_css_selector(selector_usuario).send_keys(user)
driver.find_element_by_css_selector(selector_contrasena).send_keys(psw.tolist())
driver.find_element_by_css_selector(boton_login).click()

# Mas acciones dentro de la pagina
time.sleep(200)

# Cerrar
driver.quit()