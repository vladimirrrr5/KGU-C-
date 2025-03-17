(defun calculate-radius (circumference)
  (/ circumference (* 2 pi)))

(defun calculate-area (radius)
  (* pi (expt radius 2)))

(calculate-area (calculate-radius 123))