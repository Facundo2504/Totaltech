# Comandos de Git para confirmar cambios y fusionar ramas

## Confirmar cambios locales en la rama actual
1. Verifica el estado del repositorio:
   ```bash
   git status
   ```
2. Añade los archivos modificados al área de preparación (staging). Puedes agregar archivos individuales o todos a la vez:
   ```bash
   git add <ruta/al/archivo>
   # o
   git add .
   ```
3. Confirma los cambios con un mensaje descriptivo:
   ```bash
   git commit -m "Mensaje de commit descriptivo"
   ```
4. (Opcional) Envía la rama actual al repositorio remoto:
   ```bash
   git push origin $(git branch --show-current)
   ```

## Fusionar otras ramas en `main`
1. Asegúrate de tener la versión más reciente de `main`:
   ```bash
   git checkout main
   git pull origin main
   ```
2. Lista las ramas disponibles para identificar cuáles deseas fusionar:
   ```bash
   git branch
   ```
3. Para cada rama que quieras fusionar en `main`, ejecuta:
   ```bash
   git merge <nombre-de-la-rama>
   ```
   - Si se producen conflictos, resuélvelos editando los archivos afectados, luego:
     ```bash
     git add <archivo-resuelto>
     git commit
     ```
4. Después de fusionar todas las ramas deseadas, envía los cambios a remoto:
   ```bash
   git push origin main
   ```

## Consejos adicionales
- Si prefieres crear una rama temporal para probar fusiones, crea una nueva rama a partir de `main` antes de fusionar:
  ```bash
  git checkout -b integracion-main
  ```
- Para fusionar todos los cambios de una rama remota sin descargarla manualmente, puedes usar `git fetch` y luego `git merge origin/<rama>`.
- Usa `git log --oneline --graph --decorate --all` para revisar el historial y confirmar que las fusiones se realizaron como esperabas.
