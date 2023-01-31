# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
from flask import Flask, render_template
import Ui
app = Flask(__name__)


@app.route("/")
def root():
    # Use a breakpoint in the code line below to debug your script.
    print("root")
    return render_template("index.html")


@app.route("/random-num-gen/")
def random_number():
    response = Ui.user_input(1)
    return {"message": response}


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    app.run(host='127.0.0.1', port=5000, debug=True)

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
