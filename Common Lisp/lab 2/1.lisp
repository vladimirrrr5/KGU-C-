(defvar *names* '(("И" . "Иван")
                  ("П" . "Петр")
                  ("Н" . "Николай")
                  ("В" . "Владимир")
                  ("Г" . "Георгий")))

(defun get-full-name (initial)
  (cdr (assoc initial *names* :test #'string=)))

(defun print-full-name (initial)
  (if (get-full-name initial)
      (format t "Полное имя: ~a~%" (get-full-name initial))
      (format t "Имя с первой буквой ~a не найдено.~%" initial)))

;; Пример использования
(print-full-name "И")  ;; Вывод: Полное имя: Иван
(print-full-name "П")  ;; Вывод: Полное имя: Петр
(print-full-name "А")  ;; Вывод: Имя с первой буквой А не найдено.