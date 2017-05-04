# MyMeny
Test meny with delegates
## Комманды git
* * *
* create a new repository on the command line
 echo "# MyMeny" >> README.md
 git init //создание git-a на локальной машине
 git add README.md //добавление новых файлов или обновление старых(через git add .)
 git commit -m "first commit" //создание склепка изменений(всех добавленных или изменённых данных)
 git remote add origin https://github.com/Ileha/MyMeny.git //добавление удалённого репозитория в проект
 git push -u origin master //отправка в ветку master
* * *
* Useful commands
 git pull origin master //получить последние изменения других контрибьютеров
 git log //Вся история проекта
 git log -u //Вся история проекта + изменения в коде
 git log --graph --all --decorate --oneline //Вся история проекта в виде графа
 git status //Для просмотра статуса репозитория(внесённые изменения) - работает локально

* Для перезаписи локальных изменений удалёнными
 git fetch --all
 git reset --hard origin <имя_ветки>
