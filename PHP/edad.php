<?php
                  //Crear un algoritmo que lea su edad en años y el sistema calcule su edad en meses aproximados de vida. 
                    //si el promedio de vida de un humano es de 80 años el sistema nos debe informar cuanto tiempo nos queda de vida física.  

                  $edad     =filter_input(INPUT_POST,'edad');

                  $edad_me      =$edad/24;

                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              if (edad<80) {
                                  $n_edad= 80-edad;
                                <li>Usted tiene '$edad_me' meses y le quedan '$n_edad' años de vida</li>
                            
                              else
                                $n_edad= edad-80;
                                <li>Usted tiene '$edad_me' meses y tiene '$n_edad' años de mas, esta viviendo horas extras</li>
                            </ul>   
                     </div>';
                  }
                  ?>