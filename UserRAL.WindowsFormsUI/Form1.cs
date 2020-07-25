using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserRAL.Business.Abstract;
using UserRAL.Business.DependencyResolvers.Ninject;
using UserRAL.Entities.Concrete;

namespace UserRAL.WindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private IUserService _userService = new UserManager(new EfUserDal());
        private IUserService _userService = InstanceFactory.GetInstance<IUserService>();

        //private IRoleService _roleService = new RoleManager(new EfRoleDal());
        private IRoleService _roleService = InstanceFactory.GetInstance<IRoleService>();

        private IEncryptText _encryptText = InstanceFactory.GetInstance<IEncryptText>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
        }

        private void LoadRoles()
        {
            cbxRole.DataSource = _roleService.GetAllRoles();
            cbxRole.DisplayMember = "RoleName";
            cbxRole.ValueMember = "RoleId";

            cbxRoleUpdate.DataSource = _roleService.GetAllRoles();
            cbxRoleUpdate.DisplayMember = "RoleName";
            cbxRoleUpdate.ValueMember = "RoleId";
        }

        private void LoadUsers()
        {
            dgwUsers.DataSource = _userService.GetAllUsers();
        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwUsers.DataSource = _userService.GetUsersByRole(Convert.ToInt32(cbxRole.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwUsers.DataSource = _userService.GetUsersByUserName(tbxSearch.Text);
            }
            else
            {
                LoadUsers();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.AddUser(new User
                {
                    Name = tbxUserName.Text,
                    Surname = tbxUserSurname.Text,
                    UserName = tbxUserUserName.Text,
                    Email = tbxUserEmail.Text,
                    Password = tbxUserPassword.Text,
                });
                LoadUsers();
                MessageBox.Show("Yeni kullanıcı eklendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwUsers.CurrentRow != null)
                {
                    _userService.UpdateUser(new User
                    {
                        Id = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value),
                        Name = tbxUserNameUpdate.Text,
                        Surname = tbxUserSurnameUpdate.Text,
                        UserName = tbxUserUserNameUpdate.Text,
                        Email = tbxUserEmailUpdate.Text,
                        Password = tbxUserPasswordUpdate.Text,
                        RoleId = Convert.ToInt32(cbxRoleUpdate.SelectedValue),
                        Key = (Guid)dgwUsers.CurrentRow.Cells[7].Value
                    });
                    LoadUsers();
                    MessageBox.Show("kullanıcı güncellendi.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUserNameUpdate.Text = dgwUsers.CurrentRow.Cells[2].Value.ToString();
            tbxUserSurnameUpdate.Text = dgwUsers.CurrentRow.Cells[3].Value.ToString();
            tbxUserUserNameUpdate.Text = dgwUsers.CurrentRow.Cells[4].Value.ToString();
            tbxUserEmailUpdate.Text = dgwUsers.CurrentRow.Cells[5].Value.ToString();
            tbxUserPasswordUpdate.Text = dgwUsers.CurrentRow.Cells[6].Value.ToString();
            cbxRoleUpdate.SelectedValue = dgwUsers.CurrentRow.Cells[1].Value;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwUsers.CurrentRow != null)
            {
                _userService.DeleteUser(new User
                {
                    Id = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value)
                });
                LoadUsers();
                MessageBox.Show("kullanıcı silindi.");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var password = _encryptText.Sha384Enc(tbxUserPasswordLogin.Text);

                var result = _userService.GetUserByUserNameAndPassword(new User
                {
                    UserName = tbxUserNameLogin.Text,
                    Password = password

                });

                if (result != null)
                {
                    MessageBox.Show("Giriş yapılıyor.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış..!!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
