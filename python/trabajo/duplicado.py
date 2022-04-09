import numpy as np
import pandas
import time
from pandas.core.frame import DataFrame
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as ec

#excel_credenciales = r'D:\python\aprende\codigo\robot linkedin\credenciales.xlsx'
#df = pandas.read_excel(excel_credenciales)
#user = df['usuario'][0]
#psw = df['contrasena'][0]

#correo


url = 'https://exitocol.myvtex.com/admin/site'



# Selectores:

def selectores_1p():
    correo = 'pablo.cano@arus.com.co'
    selector_email = '//*[@id="email"]'
    boton_continue = '//*[@id="render-admin.login-legacy.home"]/div/div/div/div[1]/div[2]/div[1]/div[2]/div[1]/button/div'
    driver.find_element_by_xpath(selector_email).send_keys(correo)
    driver.find_element_by_xpath(boton_continue).click()

def selectores_2p(codigo):
    code = '<input class="vtex-styleguide-9-x-input ma0 border-box vtex-styleguide-9-x-hideDecorators vtex-styleguide-9-x-noAppearance br2   w-100 bn outline-0 code bg-base c-on-base b--muted-4 hover-b--muted-3  ph5 " pattern="\d*" type="text" value="">'
    boton_continue = '//*[@id="render-admin.login-legacy.home"]/div/div/div/div[1]/div[2]/div[1]/div[2]/div[1]/button/div'
    driver.find_element_by_xpath(code).send_keys(codigo)
    driver.find_element_by_xpath(boton_continue).click()

"""boton_inicio_sesion = 'body > nav > div > a.nav__button-secondary'
selector_usuario = '#username'
selector_contrasena = '#password'
boton_login = '#organic-div > form > div.login__form_action_container > button'
"""
# Abrir navegador:

driver = webdriver.Chrome()

#Maximizar pantalla
driver.maximize_window()
driver.get(url)


#acciones en la pagina:
time.sleep(10)

selectores_1p

codigo = input("Ingrese el codigo ")

selectores_2p

"""

# Loggearnos
driver.find_element_by_css_selector(selector_usuario).send_keys(user)
driver.find_element_by_css_selector(selector_contrasena).send_keys(psw.tolist())
driver.find_element_by_css_selector(boton_login).click()

# Mas acciones dentro de la pagina
time.sleep(200)


# Cerrar
driver.quit()

"""


