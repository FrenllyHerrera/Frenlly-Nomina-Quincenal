## Nómina Quincenal - Actividad Práctica**
**Nombre:** *Frenlly Herrera.*
**Matrícula:** *2025-0300.*

## Descripción del programa
App la cual calcula el pago quincenal de los empleados con sus hors trabajadas, su contrato, cargo e incentivo de transporte. 
Y utiliza acumuladores para mostrar un resumen general.

## Datos de entrada
Nombre del empleado.
Tipo de contrato: Fijo o Temporal.
Cargo: Auxiliar, técnico, supervisor y gerente.
Horas trabajadas en la quincena.
Incentivo de transporte.

## Proceso
Se calcula el salario regular multiplicando las horas (con limite hasta 88) por la tarifa del cargo.
Las horas que sobrepasan las 88 se pagan como extras con un 35% de recargo, y se suma el incentivo de transporte si está marcado.
Si el contrato es Fijo, se aplican deducciones de AFP (2.87%) y SFS (3.04%) sobre el salario regular y extra.
Y por ulitmo secalcula el neto (que es bruto - deducciones) y se acumula para el resumen.

## Captura del programa en ejecución
<img width="1918" height="893" alt="image" src="https://github.com/user-attachments/assets/934b70bb-bc05-4a91-b817-4a359a7d7407" />
