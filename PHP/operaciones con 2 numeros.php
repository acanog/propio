
<?php
                  //Variables
                  $n1               =filter_input(INPUT_POST,'n1');
                  $n2               =filter_input(INPUT_POST,'n2');
                  $suma             =$n1+$n2;
                  $resta            =$n1-$n2;
                  $multiplicacion   =$n1*$n2;
                  $division         =$n1+$n2;


                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                           <ul class="resultado">
                              <li>Suma: ' . $suma . '</li>
                              <li>Resta: ' . $resta . '</li>
                              <li>Multiplicacion: ' . $multiplicacion . '</li>
                              <li>Division: ' . $division . '</li>
                           </ul>   
                     </div>';
                  }
                  ?>



