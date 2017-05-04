# MyMeny
Test meny with delegates
## Комманды git
* create a new repository on the command line  
    git init _//создание git-a на локальной машине_
    git add README.md _//добавление новых файлов или обновление старых(через git add .)_  
    git commit -m "first commit" _//создание склепка изменений(всех добавленных или изменённых данных)_  
    git remote add origin https://github.com/Ileha/MyMeny.git _//добавление удалённого репозитория в проект_  
    git push -u origin master _//отправка в ветку master_  
* * *
* Useful commands  
    git pull origin master _//получить последние изменения других контрибьютеров_  
    git log _//Вся история проекта_  
    git log -u _//Вся история проекта + изменения в коде_  
    git log --graph --all --decorate --oneline _//Вся история проекта в виде графа_  
    git status _//Для просмотра статуса репозитория(внесённые изменения) - работает локально_  
* * *
* Для перезаписи локальных изменений удалёнными  
    git fetch --all  
    git reset --hard origin <имя_ветки>  
* * *
* Работа с ветками  
    git branch _//просмотр доступных веток_  
    git branch -v _//расширенный просмотр веток_  
    git branch <имя новой ветки> _//создание новой ветки_  
    git checkout <имя существующей ветки> _//преключение на существующую ветку  
* * *
*  Конфиги git  
    располагается: $HOME/.gitconfig  
## Редактирование README.md  
[Краткое руководство по Маркдауну](http://paulradzkov.com/2014/markdown_cheatsheet/ "Я ссылка")
