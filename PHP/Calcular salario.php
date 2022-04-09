
<?php
                  //Variables

                  $salario     =filter_input(INPUT_POST,'salario');
                  $salud       =($salario*9)/100;
                  $pension     =($salario*12)/100;

                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>El valor de la salud es : ' . $salud . '</li>
                              <li>El valor de la pension es: ' . $pension . '</li>
                           </ul>   
                     </div>';
                  }

                  //Crear un pseudocódigo que lea el salario de un empleado y calcule su salud del 9% y pensión del 12%

                  ?>



