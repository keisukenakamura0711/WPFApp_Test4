using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFApp_Test4.Models;

namespace WPFApp_Test4.ViewModels
{
    internal class MainViewModel : NotificationObject
    {
        private ObservableCollection<Person> _people = new ObservableCollection<Person>();
        /// <summary>
        /// 人物情報のコレクションを取得します。
        /// </summary>
        public ObservableCollection<Person> People
        {
            get { return this._people; }
            private set { SetProperty(ref this._people, value); }
        }

        private int _count;

        private DelegateCommand _addCommand;
        /// <summary>
        /// 追加コマンドを取得します。
        /// </summary>
        public DelegateCommand AddCommand
        {
            get
            {
                return this._addCommand ?? (this._addCommand = new DelegateCommand(
                _ =>
                {
                   this._count++;
                   var person = new Person()
                   {
                       FamilyName = "田中",
                       FirstName = this._count + "太郎",
                       Age = this._count,
                   };
                   this.People.Add(person);
                   this.DeleteCommand.RaiseCanExecuteChanged();

                   System.Diagnostics.Debug.WriteLine(person.FullName + " を追加しました。");
                }));
            }
        }

        public DelegateCommand _deleteComand;
        /// <summary>
        /// 削除コマンドを取得します。
        /// </summary>
        public DelegateCommand DeleteCommand
        {
            get
            {
                return this._deleteComand ?? (this._deleteComand = new DelegateCommand(
                p =>
                {
                    this.People.Remove(p as Person);
                    this.DeleteCommand.RaiseCanExecuteChanged();
                }));
            }
        }
    }
}
