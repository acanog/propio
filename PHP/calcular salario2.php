<?php
                  //la semana y calcule su salario sabiendo que cada hora se paga a $33.000 y se le da un auxilio de transporte de $11.111

                  $horas     =filter_input(INPUT_POST,'horas');

                  $pago      =($horas*33000)+11111;

                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>El valor del salario a pagar es : ' . $pago . '</li>
                            </ul>   
                     </div>';
                  }
                  ?>