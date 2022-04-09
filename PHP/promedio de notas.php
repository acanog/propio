<?php
                  //Crear un algoritmo que lea 3 notas diferentes de un estudiante y el sistema calcule su promedio.

                  $nota1     =filter_input(INPUT_POST,'nota1');
                  $nota2     =filter_input(INPUT_POST,'nota2');
                  $nota3     =filter_input(INPUT_POST,'nota3');

                  $suma       =$nota1+$nota2+$nota3;
                  $promedio   =$suma / 3;

                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>El valor de la cuota es : ' . $promedio . '</li>
                            </ul>   
                     </div>';
                  }
                  ?>