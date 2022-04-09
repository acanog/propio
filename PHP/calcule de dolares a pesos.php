
<?php
                  //Crear un algoritmo que lea una cantidad de dinero en Dólares USD y el sistema los calcule a pesos colombianos COP.

                  $dolares     =filter_input(INPUT_POST,'dolares');
                  $pesos       =$dolares*3500;

                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>La cantidad de dinero en pesos es : ' . $pesos . '</li>
                            </ul>   
                     </div>';
                  }
                  ?>