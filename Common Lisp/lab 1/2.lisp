(defun f (x)
  (- (tan x)                    
     (expt (tan x) 2)            
     (* 0.2 (expt (tan x) 3))))  

(defun g (x)
  (- (* 3 (log (+ (expt x 4) 2.8))) 
     x))                            

(defun calculate-and-print (x)
  (format t "f = ~a~%" (f x))
  (format t "g = ~a~%" (g x)))

(calculate-and-print 1.0)