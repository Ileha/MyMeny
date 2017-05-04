# MyMeny
Test meny with delegates
## Комманды git
* create a new repository on the command line
    git init __//создание git-a на локальной машине__
    git add README.md __//добавление новых файлов или обновление старых(через git add .)__
    git commit -m "first commit" __//создание склепка изменений(всех добавленных или изменённых данных)__
    git remote add origin https://github.com/Ileha/MyMeny.git __//добавление удалённого репозитория в проект__
    git push -u origin master __//отправка в ветку master__
* * *
* Useful commands
    - git pull origin master //получить последние изменения других контрибьютеров
    - git log //Вся история проекта
    - git log -u //Вся история проекта + изменения в коде
    - git log --graph --all --decorate --oneline //Вся история проекта в виде графа
    - git status //Для просмотра статуса репозитория(внесённые изменения) - работает локально
* * *
* Для перезаписи локальных изменений удалёнными
    - git fetch --all
    - git reset --hard origin <имя_ветки>
