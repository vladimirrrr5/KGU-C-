" Условие: известна длина окружности. Найдите площадь круга, ограниченного этой окружностью.
1. Находим радиус по формуле: r = C/2pi, где C - длина окружности
2. Находим площадь круга по формуле: S = pi*r^2
func_Radius - функция радиуса
circumference - окружность
func_Area - функция круга
Имя: func_Radius, func_Area
Структура данных: circumference - положительное число
Вход: положительное число
Выход: положительное число"
(defun func_Radius (circumference)
  (/ circumference (* 2 pi)))



(defun func_Area (radius)
  (* pi (expt radius 2)))


(func_Area (func_Radius 5))

(test func_Radius)
