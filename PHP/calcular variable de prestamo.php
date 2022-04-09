<?php
                  //crear un algoritmo que lea un monto de dinero por concepto de préstamo y el sistema solicite el plazo en meses para amortizar, el sistema cobrará un interés del 9% sobre la suma total, calcular el valor de cada cuota a pagar.

                  $prestamo     =filter_input(INPUT_POST,'prestamo');
                  $n_cuotas       =filter_input(INPUT_POST,'n_cuotas');

                  $prestamo_i       =($prestamo*9)/100;
                  $v_cuota          =$prestamo_i/ $n_cuotas;

                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>El valor de la cuota es : ' . $v_cuota . '</li>
                            </ul>   
                     </div>';
                  }
                  ?>