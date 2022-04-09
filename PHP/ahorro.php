<?php
                  //Crear un algoritmo que lea una cantidad de dinero pago mensual  para ahorro en una cooperativa, el sistema debe calcular su ahorro anual con una tasa de interés del 29%  


                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m1');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m2');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m3');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m4');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m5');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m6');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m7');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m8');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m9');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m10');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m11');
                  $ahorro_m     =filter_input(INPUT_POST,'ahorro_m12');

                  $ahorro_t      =$ahorro_1+$ahorro_2+$ahorro_3+$ahorro_4+$ahorro_5+$ahorro_6+$ahorro_7+$ahorro_8+$ahorro_9+$ahorro_10+$ahorro_11+$ahorro_12;
                  $ahorro_i      =($ahorro_t*29)/100;
                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>El ahorro anual mas interes del 29% es de '$ahorro_i'</li>
                            </ul>   
                     </div>';
                  }
                  ?>